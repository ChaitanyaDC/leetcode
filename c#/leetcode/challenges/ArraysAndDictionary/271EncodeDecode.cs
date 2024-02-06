namespace leetcode.challenges.ArraysAndDictionary._271EncodeDecode;
public class Codec {

    // Encodes a list of strings to a single string.
    public string encode(IList<string> strs) {
        string result = "";
        foreach (string str in strs)
        {
            result += str.Length + "#" + str;
        }
        return result;
    }

    // Decodes a single string to a list of strings.
    public IList<string> decode(string s) {
        int i = 0;
        List<string> result = new List<string>();

        while (i < s.Length)
        {
            int length = int.Parse(s[i].ToString());
            if (s[i + 1] == '#')
            {
                result.Add(s.Substring(i + 2, length));
                i += length + 2;
            }
        }

        return result;
    }
}

public static class _271EncodeDecode {

    public static void Test() {
        List<string> strs = new List<string> { "neet", "co#de" };
        Codec codec = new();

        string encodedString = codec.encode(strs);
        Console.WriteLine("Encoded string: " + encodedString);

        string decodedString = "4#neet5#co#de";
        IList<string> decodedList = codec.decode(decodedString);
        Console.WriteLine("Decoded list: " + string.Join(", ", decodedList));
    }
}
