namespace Sep.Git.Tfs
{
    public static class GitTfsConstants
    {
        public const string DefaultRemoteId = "default";
        public static readonly Regex Sha1 = new Regex("[a-f\\d]{40}",   RegexOptions.IgnoreCase);
        public static readonly Regex Sha1 = new Regex("[a-f\\d]{4,40}", RegexOptions.IgnoreCase);
    }
}
