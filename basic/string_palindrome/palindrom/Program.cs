bool isPalindrom(string text)
{
    string lower = text.ToLower();
    for (int i = 0; i < lower.Length / 2;i++)
    {
        if (lower[i] != lower[lower.Length - i - 1])
        {
            return false;
        }
    }
    return true;
}
Console.WriteLine(isPalindrom("burak"));