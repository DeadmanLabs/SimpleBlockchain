using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.IO;

namespace Blockchain
{
    public class Blockchain<T>
    {
        public List<Block<T>> chain { get; private set; }
        public List<T> buffer { get; set; }
        public string currentHash { get; private set; }
        public int difficulty { get; private set; }
        public Blockchain(int difficulty = 4)
        {
            if (difficulty < 1) { throw new Exception("Blockchain difficulty must be greater then 0!"); }
            this.chain = new List<Block<T>>();
            this.buffer = new List<T>();
            this.difficulty = difficulty;
        }

        public Block<T> push()
        {
            if (buffer.Count > 0)
            {
                Console.Write("Mining Started...");
                Block<T> block = new Block<T>(chain.Count, buffer.ToArray(), mine(chain.Count > 1 ? Last().proof : 0), chain.Count > 1 ? currentHash : "GENISIS");
                Console.WriteLine("Done!");
                buffer = new List<T>();
                chain.Add(block);
                Console.WriteLine("New Blockchain! Size: " + chain.Count.ToString());
                currentHash = block.Hash();
                Console.WriteLine("New Blockhash: " + currentHash);
                return block;
            }
            return null;
        }

        public Block<T> Last()
        {
            return chain.Last();
        }

        private int mine(int last_proof)
        {
            int proof = 0;
            while (!prove(last_proof, proof))
            {
                proof += 1;
            }
            return proof;
        }

        private bool prove(int last, int current)
        {
            string challange = last.ToString() + current.ToString();
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hash = sha256.ComputeHash(Encoding.UTF8.GetBytes(challange));
                string rawHash = "";
                foreach (byte b in hash)
                {
                    rawHash += b.ToString("x2");
                }
                Console.WriteLine(rawHash.Substring(0, this.difficulty) + " vs. " + new string('0', this.difficulty));
                return rawHash.Substring(0, this.difficulty) == new string('0', this.difficulty);
            }
        }

        public bool validate()
        {
            foreach (Block<T> block in chain)
            {
                if (block.index != 0)
                {
                    if (block.prevHash != chain[block.index - 1].Hash())
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }

    public class Block<T>
    {
        public int index { get; private set; }
        public DateTime timestamp { get; private set; }
        public T[] objects { get; private set; }
        public int proof { get; private set; }
        public string prevHash { get; private set; }

        public Block(int index, T[] objects, int proof, string prevHash)
        {
            this.index = index;
            this.timestamp = DateTime.Now;
            this.objects = objects;
            this.proof = proof;
            this.prevHash = prevHash;
        }

        public string Hash()
        {
            byte[] bytes;
            using (MemoryStream ms = new MemoryStream())
            {
                IFormatter converter = new BinaryFormatter();
                converter.Serialize(ms, objects);
                bytes = ms.ToArray();
            }
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hash = sha256.ComputeHash(bytes);
                string rawHash = "";
                foreach (byte b in hash)
                {
                    rawHash += b.ToString("x2");
                }
                return rawHash;
            }
        }
    }
}
