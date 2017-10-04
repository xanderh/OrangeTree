using System;

namespace Ex10_OrangeTree
{
    internal class OrangeTree
    {
        private int age;
        private int height;
        private int numOranges;
        private bool treeAlive;
        private int orangesEaten;

        public OrangeTree(int age, int height)
        {
            // Sets the age and height, and makes sure that the tree is alive. 
            this.age = age;
            this.height = height;
            this.treeAlive = true;
        }

        public int Age
        {
            get {
                return age;
            }
            internal set {
                this.age = value;
            }
        }
        public int Height
        {
            get {
                return height;
            }
            internal set {
                height = value;
            }
        }
        public bool TreeAlive
        {
            get {
                return treeAlive;
            }
            internal set {
                treeAlive = value;
            }
        }
        public int NumOranges
        {
            get {
                return numOranges;
            }
            internal set {
                numOranges = value;
            }
        }
        public int OrangesEaten { get {
                return orangesEaten;
            }
            internal set {
                orangesEaten = value;
            } }

        internal void OneYearPasses()
        {
            // age the tree and increase the height
            age++;
            height = height + 2;
            // If the tree is at least 80 years old, it is now dead.
            if (age >= 80) {
                treeAlive = false;
            }
            // Make sure that the tree has fruit if it's old enough. 
            // Fruit from last year doesn't carry over. 
            if (age > 1) {
                NumOranges = (age-1) * 5;
            }
        }

        internal void EatOrange(int v)
        {
            // Make sure there's enough fruit, otherwise throw an exception
            if (v > NumOranges) {
                throw new IndexOutOfRangeException();
            } else {
            NumOranges = NumOranges - v;
            OrangesEaten = OrangesEaten + v;
            }
        }
    }
}