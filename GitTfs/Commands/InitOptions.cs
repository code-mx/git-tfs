namespace Sep.Git.Tfs.Commands
{
    [StructureMapSingleton]
    public class InitOptions
    {
        [OptDef(OptValType.ValueReq)]
        [LongOptionName("template")]
        [UseNameAsLongOptionName(false)]
        [Description("The --template option to pass to git-init.")]
        public string GitInitTemplate { get; set; }

        [OptDef(OptValType.ValueOpt)]
        [LongOptionName("shared")]
        [UseNameAsLongOptionName(false)]
        [Description("The --shared option to pass to git-init.")]
        public object GitInitShared { get; set; }

        [OptDef(OptValType.Flag)]
        [LongOptionName("no-metadata")]
        [UseNameAsLongOption(false)]
        [Description("If specified, git-tfs will leave out the git-tfs-id: lines at the end of every commit.")]
        public bool NoMetaData { get; set; }

        [OptDef(OptValType.ValueReq)]
        [Description("An optional remote ID, useful if this repository will track multiple TFS repositories.")]
        public string id { get; set; }

    }
}
