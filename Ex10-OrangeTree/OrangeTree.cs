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
            age++;
            height = height + 2;
            if (age >= 80) {
                treeAlive = false;
            }
            if (age > 1) {
                NumOranges = (age-1) * 5;
            }
        }

        internal void EatOrange(int v)
        {
            if (v > NumOranges) {
                throw new IndexOutOfRangeException();
            } else {
            NumOranges = NumOranges - v;
            OrangesEaten = OrangesEaten + v;
            }
        }
    }
}