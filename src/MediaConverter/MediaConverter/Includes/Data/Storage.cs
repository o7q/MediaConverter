namespace MediaConverter.Data
{
    public static class Storage
    {
        public const string VERSION = "v1.0.1";

        public const string baseArguments = "@echo off\n" +
                                            "cd \"MediaConverter\\working\"\n" +
                                            "type \"mc_header\"";
    }
}