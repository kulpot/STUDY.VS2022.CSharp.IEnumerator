using System;
using System.Collections;
//using System.Collections.Generic;

//ref link:https://www.youtube.com/watch?v=2EqUvjJFeWA&list=PLRwVmtr-pp07QlmssL4igw1rnrttJXerL&index=13
//ctrl+shift+space --- check details 
// list -- are dynamic, can grow and shrink
// list -- manage array underneath
// all link function rely on IEnumerator

class MeList<T>
{
    T[] items = new T[5];
    int count;
    public void Add(T item)
    {
        if (count == items.Length)
            Array.Resize(ref items, items.Length * 2);  // resize the underlying containers --- add slots by x2 of previous slot
        items[count++] = item;
    }
    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < count; i++)
            yield return items[i];      // requires yield return knowledge
    }
}

static class MainClass
{
    static void Main()
    {
        //int[] ints = new int[] { 25, 34, 32 };
        //ArrayList myPartyAges = new ArrayList();    // none generic
        //myPartyAges.Add(25);
        //myPartyAges.Add(34);
        //myPartyAges.Add("Billy");
        //myPartyAges.Add(32);
        //myPartyAges.Add(99);
        //List<int> myPartyAges2 = new List<int>();   //generic list
        MeList<int> myPartyAges2 = new MeList<int>();
        myPartyAges2.Add(25);
        myPartyAges2.Add(34);
        myPartyAges2.Add(32);
        myPartyAges2.Add(36);
        foreach(int i in myPartyAges2)
            Console.WriteLine(i);
        //IEnumerator<int> rator = myPartyAges2.GetEnumerator();  //IEnumerator(sentinel value) -- allow you to trace another sequence
        //IEnumerator<int> billy = myPartyAges2.GetEnumerator();
        //IEnumerator<int> johnny = myPartyAges2.GetEnumerator();
        //Console.WriteLine(billy.Current); // invalid current call(will defualt to 0) -- when called befored MoveNext
        //billy.MoveNext();
        //johnny.MoveNext();
        //billy.MoveNext();
        //billy.MoveNext();
        //billy.MoveNext();
        //billy.MoveNext();
        //billy.MoveNext();
        //billy.MoveNext();
        //billy.MoveNext();
        //billy.MoveNext();
        //billy.MoveNext();
        //billy.MoveNext();
        //billy.MoveNext();
        //billy.MoveNext();
        //Console.WriteLine(billy.Current);
        //Console.WriteLine(johnny.Current);

        //while (rator.MoveNext())
        //    Console.WriteLine(rator.Current);
    }
}