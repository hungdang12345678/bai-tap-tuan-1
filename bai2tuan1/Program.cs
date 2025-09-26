using System;
namespace SearchAndSort
{
    class ArrayProcessor
    {
        private int[] arr;
        public void Input()
        {
            Console.Write("Nhap so phan tu cua mang: ");
            int n = int.Parse(Console.ReadLine());
            arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Phan tu [{i}] = ");
                arr[i] = int.Parse(Console.ReadLine());
            }
        }
        public void Display()
        {
            Console.WriteLine(string.Join(" ", arr));
        }
        public void BubbleSort()
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
        public void QuickSort(int left, int right)
        {
            int i = left, j = right;
            int pivot = arr[(left + right) / 2]; 
            while (i <= j)
            {
                while (arr[i] < pivot) i++;
                while (arr[j] > pivot) j--;

                if (i <= j)
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    i++;
                    j--;
                }
            }
            if (left < j) QuickSort(left, j);
            if (i < right) QuickSort(i, right);
        }
        public int LinearSearch(int key)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == key)
                    return i; 
            }
            return -1; 
        }
        public int BinarySearch(int key)
        {
            int left = 0, right = arr.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;

                if (arr[mid] == key)
                    return mid;
                else if (arr[mid] < key)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            return -1; 
        }
        public int[] GetArray()
        {
            return arr;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ArrayProcessor ap = new ArrayProcessor();
            ap.Input();

            Console.WriteLine("\nMang ban dau:");
            ap.Display();
            ap.BubbleSort();
            Console.WriteLine("\nMang sau khi xap xep bang Bubble Sort:");
            ap.Display();
            int[] arrCopy = (int[])ap.GetArray().Clone(); 
            ArrayProcessor ap2 = new ArrayProcessor();
            typeof(ArrayProcessor).GetField("arr",
                System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                .SetValue(ap2, arrCopy);

            ap2.QuickSort(0, arrCopy.Length - 1);
            Console.WriteLine("\nMang sau khi sap xep bang Quick Sort:");
            ap2.Display();
            Console.Write("\nNhap so can tim: ");
            int key = int.Parse(Console.ReadLine());

            int posLinear = ap.LinearSearch(key);
            if (posLinear != -1)
                Console.WriteLine($"Linear Search: tim thay {key} vi tri {posLinear}");
            else
                Console.WriteLine("Linear Search: khong tim thay");

            int posBinary = ap.BinarySearch(key);
            if (posBinary != -1)
                Console.WriteLine($"Binary Search: tim thay {key} tai vi tri {posBinary}");
            else
                Console.WriteLine("Binary Search: khong tim thay");

            Console.WriteLine("\n--- ket thuc ---");
        }
    }
}
