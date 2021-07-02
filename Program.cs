using System;
using System.Collections.Generic;
using System.Linq;


int pairsOfSocks = 0 ;
int y =0;

// defining a list according to the Microsoft docs example.
// This is the data source that i will query
// data creation
List<int> socks = new List<int>();
// I will look into a faster way to declare a dynamic list.
socks.Add(1);
socks.Add(2);
socks.Add(3);
socks.Add(1);
socks.Add(2);
socks.Add(1);
//socks[1, 2, 3, 1, 2, 1, 2]




IEnumerable<int> findPairsOfColor1 =
    from pairs in socks
    where pairs == 1 //condition 
    select pairs;

foreach (int x in findPairsOfColor1)
{
    //Console.WriteLine(x);
    //Console.WriteLine("test");
    y++;
}
Console.WriteLine(y);// tests that y is incrementing based on successful queries.
findTotalPairs(y);




//Query creation
IEnumerable<int> findPairsOfColor2 =
    from pairs in socks
    where pairs == 2 //condition 
    select pairs;

foreach (int x in findPairsOfColor2)
{
    //Console.WriteLine(x);
    //Console.WriteLine("test");
    y++;
}
findTotalPairs(y);



IEnumerable<int> findPairsOfColor3 =
    from pairs in socks
    where pairs == 3 //condition 
    select pairs;

foreach (int x in findPairsOfColor3)
{
    //Console.WriteLine(x);
    //Console.WriteLine("test");
    y++;
}

findTotalPairs(y);

void findTotalPairs(int num)
{
    if (num == 1)
    {
        Console.WriteLine("there are no pairs");

    }
    else if(num == 2)
    {
        Console.WriteLine("you have 1 pair");
    }
    else
    {
        int remainder = 0;
        remainder = num % 2;
        num = num - remainder;
        if (num == 2)
        {
            num = num / 2;
        }
        //executing query
        Console.WriteLine("the total number of pairs are {0}", num);
    }
    y = 0;
}










