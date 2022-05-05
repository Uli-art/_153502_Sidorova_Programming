using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Multiplicitycs
    {
        char[] array;


        public Multiplicitycs(){
            array = new char[1];
        }

        public Multiplicitycs(char[] newArray)
        {
            if (Unique(newArray))
            {
                array = new char [newArray.Length];
                for (int i = 0; i < newArray.Length; ++i) {
                    array[i] = newArray[i];
                }
            }
            else {
                array = Array.Empty<char>();
            }
        }

        public Multiplicitycs(int size)
        {
            array = new char[size];
        }

        public char this[int index]
        {
            get { return array[index]; }
            set
            {
                if (!IsItIn(value))
                {
                    array[index] = value;
                }
            }
        }
        public bool Unique(char[] array)
        {
            for (int i = 0; i < array.Length; ++i) {
                for (int j = i + 1; j < array.Length; ++j) {
                    if (array[i] == array[j])
                        return false;
                }
            }
            return true;
        }

        public bool IsItIn(char value) {
            for (int i = 0; i < array.Length; ++i)
            {
                if (array[i] == value)
                    return false;
            }
            return true;
        }

        public char[] getArray()
        {
            return array;
        }

        public static Multiplicitycs operator +(Multiplicitycs first, Multiplicitycs second)
        {
            int minSize = Math.Min(first.array.Length, second.array.Length);
            for (int i = 0; i < minSize; ++i) { 
                first.array[i] = (char)((first.array[i] - '0') + (second.array[i] - '0') + '0');
            }
            return first;
        }

        public static Multiplicitycs operator -(Multiplicitycs first, Multiplicitycs second)
        {
            int minSize = Math.Min(first.array.Length, second.array.Length);
            for (int i = 0; i < minSize; ++i)
            {
                first.array[i] = (char)((first.array[i] - '0') - (second.array[i] - '0') + '0');
            }
            return first;
        }

        public static Multiplicitycs operator *(Multiplicitycs first, Multiplicitycs second)
        {
            int minSize = Math.Min(first.array.Length, second.array.Length);
            for (int i = 0; i < minSize; ++i)
            {
                first.array[i] = (char)((first.array[i] - '0' ) * (second.array[i] - '0') + '0');
            }
            return first;
        }

        public static bool operator ==(Multiplicitycs first, Multiplicitycs second)
        {
            if(first.array.Length != second.array.Length)
                return false;
            int Size = first.array.Length;
            for (int i = 0; i < Size; ++i)
            {
                if (first.array[i] != second.array[i]) { 
                    return false;
                }
            }
            return true;
        }

        public static bool operator !=(Multiplicitycs first, Multiplicitycs second)
        {
            if (first.array.Length != second.array.Length)
                return true;
            int Size = first.array.Length;
            for (int i = 0; i < Size; ++i)
            {
                if (first.array[i] != second.array[i])
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator true(Multiplicitycs other) {
            if (other.array.Length == 0)
                return false;
            return true;
        }

        public static bool operator false(Multiplicitycs other)
        {
            if (other.array.Length == 0)
                return false;
            return true;
        }

        public static implicit operator string(Multiplicitycs p) 
        {
            string s = p.ToString();
            return s;
        }

        public static explicit operator Multiplicitycs(string p)
        {
            char[] chars = p.ToCharArray();
            return new Multiplicitycs(chars);
        }

        override public string ToString() {
            string s = "";
            for (int i = 0; i < array.Length; ++i) {
                s += array[i].ToString();
            }
            return s;
        }
    }

    
}
