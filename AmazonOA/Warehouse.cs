using System;
using System.Collections.Generic;
using System.Text;

namespace AmazonOA
{
    class Warehouse
    {
        int[,] locations;
        public int[,] KClosest(int[,] locations, int K)
        {
            this.locations = locations;
            sort(0, locations.Length - 1, K);
            int[,] res = new int[K,K];
            Array.Copy(locations,0, res, 0, K);
            return res;



        }

        public void sort(int i, int j, int K)
        {
            if (i > j) return;
            int k = RandomNumber(i,j);

            swap(i, k);

            int mid = partition(i, j);
            int leftLength = mid - i + 1;
            if (K < leftLength)
                sort(i, mid - 1, K);
            else if (K > leftLength)
                sort(mid + 1, j, K - leftLength);
        }

        public int partition(int i, int j)
        {
            int oi = i;
            int pivot = dist(i);
            i++;

            while (true)
            {
                while (i < j && dist(i) < pivot)
                    i++;
                while (i <= j && dist(j) > pivot)
                    j--;
                if (i >= j) break;
                swap(i, j);
            }
            swap(oi, j);
            return j;
        }

        public int dist(int i)
        {
            return locations[i,0] * locations[i,0] + locations[i,1] * locations[i,1];
        }

        public void swap(int i, int j)
        {
            int t0 = locations[i,0], t1 = locations[i,1];
            locations[i,0] = locations[j,0];
            locations[i,1] = locations[j,1];
            locations[j,0] = t0;
            locations[j,1] = t1;
        }

        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

    }
}
