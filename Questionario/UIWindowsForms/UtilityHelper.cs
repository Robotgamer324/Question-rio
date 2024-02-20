public static class UtilityHelper
{
    public static int GetMostFrequentValueFromList(List<int> list)
    {
        // Cria um dicionário para armazenar a contagem de cada elemento da lista.
        var frequencyDictionary = new Dictionary<int, int>();
        foreach (var item in list)
        {
            if (frequencyDictionary.ContainsKey(item))
            {
                frequencyDictionary[item]++;
            }
            else
            {
                frequencyDictionary[item] = 1;
            }
        }

        // Retorna o valor com a maior contagem no dicionário.
        return frequencyDictionary.OrderByDescending(x => x.Value).First().Key;
    }
}