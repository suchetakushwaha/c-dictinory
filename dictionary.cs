using System;
using System.Collections.Generic;
namespace DictionaryGeneriCollection 
{
  class Program
  {
    static void Main(string[] args)
    {
      Dictionary<string,string> myDict = new Dictionary<string, string>();
      myDict.Add("active","ready to engage in physically");
      myDict.Add("Amazing","causing great surprise or wonderful");
      myDict.Add("Honest","free to decit");
      myDict.Add("Patriotic","Expressing devotion to");
      myDict.Add("Quarantine","place of isolation");
     // System.Console.WriteLine(myDict["active"]);  // accessing the dictionary element through keys.
      // foreach(KeyValuePair<string,string> item in myDict) // keyvaluepair is class, in dictionary we use it for accessing the key value 
      // {
      //     Console.WriteLine("key is:" + item.Key +"  " + " value is:" + item.Value);
      // }
 foreach(string key in myDict.Keys)
 {
       Console.WriteLine(key);
 }
// foreach(string value in myDict.Values)
// {
//   Console.WriteLine(value);
// }
    }
  }

}