public class MergeFilesByPairs {
    public int mergeFiles(int numOfSubFiles, List<Integer> files) {
        int resSum = 0;
        PriorityQueue<Integer> minHeap = new PriorityQueue<>((o1, o2) -> o1 - o2);
        for (int i = 0; i < files.size(); i++) {
            minHeap.add(files.get(i));
        }
        while (minHeap.size() != 1) {
            int a = minHeap.poll();
            int b = minHeap.poll();
            int temSum = a + b;
            resSum += temSum;
            minHeap.add(temSum);
        }
        return resSum;
    }

    public static void main(String[] args) {
        MergeFilesByPairs test = new MergeFilesByPairs();
        // TEST CASE1: files =  {8， 4， 6， 12}
        int numOfSubFiles = 4;
        List<Integer> list = new ArrayList<>();
        list.add(8);
        list.add(4);
        list.add(6);
        list.add(12);
        System.out.println("TEST CASE1:");
        System.out.println(test.mergeFiles(numOfSubFiles, list));

        // TEST CASE2: files =  {3, 1, 2}
        int n2 = 3;
        List<Integer> l2 = new ArrayList<>();
        l2.add(3);
        l2.add(1);
        l2.add(2);
        System.out.println("TEST CASE2:");
        System.out.println(test.mergeFiles(n2, l2));

        // TEST CASE3: files =  {8, 3, 5, 2, 15}
        int n3 = 5;
        List<Integer> l3 = new ArrayList<>();
        l3.add(8);
        l3.add(3);
        l3.add(5);
        l3.add(2);
        l3.add(15);
        System.out.println("TEST CASE3:");
        System.out.println(test.mergeFiles(n3, l3));
    }
}