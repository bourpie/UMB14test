public class NavigationItem
{
    public string Nom { get; set; }
    public string Url { get; set; }
    public IEnumerable<NavigationItem> SubItems { get; set; }
}
