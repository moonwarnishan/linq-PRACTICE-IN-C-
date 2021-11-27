using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Channels;
using P1;
/*
List<Teacher> teachers=new List<Teacher>()
{
    new Teacher(1,"one","Teacher1"),
    new Teacher(2,"two","Teacher2"),
    new Teacher(3,"three","teacher3"),
    new Teacher(4,"four","Teacher4"),
    new Teacher(5,"five","Teacher5"),
    new Teacher(6,"six","Teacher6"),
    new Teacher(7,"seven","Teacher7"),
    new Teacher(8,"eight","Teacher8"),
    new Teacher(9,"nine","Teacher9"),
    new Teacher(10,"ten","Teacher10"),
    new Teacher(11,"eleven","Teacher11")
};

//var t=teachers.Where(i=>i._Id>7).Where(i=>i._Id<10).Select(i=>i._Name);
//var t = teachers.Where(i => i._Id > 4).OrderByDescending(i => i._Id);
var t = teachers.GroupBy(i => i._Id);
foreach (var xTeacher in t)
{
    Console.WriteLine("hello from {0}",xTeacher.Key);
    foreach (var s in xTeacher)
    {
        Console.WriteLine("Name: {0}",s._Name);
    }
}

List<string> strList1 = new List<string>() {   
    "One",
    "Two",
    "Three",
    "Four"
};
List<string> strList2 = new List<string>()
{
    "One",
    "Two",
    "Three",
    "Five",
    "Six"
};
var x = strList1.Join(
    strList2, 
    str1 => str1,  
    str2 => str2, 
    (str1, str2) => str1);

foreach (var y in x)
{
    Console.WriteLine(y);   
}

//var x = teachers.Any(i => i._Id > 0 && i._Id < 25);

List<string> strList1 = new List<string>() {
    "One",
    "Two",
    "Three",
    "Four"
};
var x = strList1.Aggregate((s1, s2) => s1+","+s2);
Console.WriteLine(x);
*/
List<int> ints=new List<int>(){10,12,13,14,15,6,7,8,5,6,7};
List<int> ints2 = new List<int>() {10, 11, 12, 13, 14, 15};
//var x=ints.Average();
//var x= ints.Count();
//var x = ints.Max();
//var x = ints.Sum();
//var x = ints.FirstOrDefault();
//var x = ints.ElementAt(7);
//var x = ints.ElementAtOrDefault(15);
//var x = ints.LastOrDefault();
//var x = ints.SingleOrDefault(i=>i==1);
//var i = ints.Concat(ints2);
//var j = i.Distinct();
//var j = ints.Except(ints2);
//var j = ints.Intersect(ints2);
//var j = ints.Union(ints2);
// foreach (var x in j)
// {
//     Console.WriteLine(x);
// }
// const string companyName="ACME";
// const string ProductName=$"{companyName} hi";
// string greed=$"hi {ProductName} i am from product";
// Console.WriteLine(greed);
Console.WriteLine("Hey");
Console.WriteLine("Hello World");

