// See https://aka.ms/new-console-template for more information

/// <summary>
/// Find the absolute difference between the number of Occurences

/// Input  AAABAB
/// Output 2
/// 
/// Input AAAAAAAAB
/// Output 7
/// 
/// Input BB
/// Output 1
/// 
/// Developed by Ümit Sözen
/// </summary>



// Function call

// Test 1
AbsoluteNumberOfLetterOccurences("AAABAB");
// Test 2
AbsoluteNumberOfLetterOccurences("AAAAAAAAB");
// Test 3
AbsoluteNumberOfLetterOccurences("BB");

// Function to find the absolute difference between the number of letter occurrences 
static void AbsoluteNumberOfLetterOccurences(string str)
{
	char[] c = str.ToCharArray();
	Dictionary<char, int> dic = new Dictionary<char, int>();

	for (int i = 0; i < c.Length; i++)
	{
		if (dic.ContainsKey(c[i]))
			dic[c[i]]++;
		else
			dic.Add(c[i], 1);
	}
	foreach (var item in dic)
		Console.WriteLine($"{item.Key } : {item.Value}");
	int aVal = 0;
	int bVal = 0;
	//string consists of only 'A' and 'B'
	dic.TryGetValue('A', out aVal);
	dic.TryGetValue('B', out bVal);
	int absValue = Math.Abs(bVal - aVal);
	Console.WriteLine($"|A-B| = {absValue}");
}