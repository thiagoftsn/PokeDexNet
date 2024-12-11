namespace WebApp.Helpers
{
    public static class Helper
    {
        public static string FormatPokemonId(int id)
        {
            return $"#{id.ToString("D4")}";
        }

        public static string Capitalize(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) return string.Empty;
            return char.ToUpper(name[0]) + name.Substring(1);
        }
    }
}
