namespace MediaConverter.Data.Structure
{
    public static class MediaStructure
    {
        public struct MediaItemData
        {
            public string INPUT_FILE_PATH;
            public string INPUT_FILE;
            public string INPUT_FILE_NAME;

            // OUTPUT SETTINGS
            public string OUTPUT_FILE_PATH;
            public string OUTPUT_FILE_NAME;
            //

            // CODEC SETTINGS
            public string OUTPUT_FORMAT;
            public string OUTPUT_FORMAT_TYPE;
            public string OUTPUT_FORMAT_PREPROCESSOR;
            public bool OUTPUT_FORMAT_IS_IMAGE_SEQUENCE;

            public string OUTPUT_VIDEO_CODEC;
            public string OUTPUT_AUDIO_CODEC;

            public string OUTPUT_VIDEO_BITRATE;
            public string OUTPUT_AUDIO_BITRATE;
            //

            // EDIT SETTINGS
            public bool OUTPUT_USE_RESIZE_VIDEO;
            public string OUTPUT_VIDEO_WIDTH;
            public string OUTPUT_VIDEO_HEIGHT;

            public bool OUTPUT_USE_CHANGE_FRAMERATE;
            public string OUTPUT_VIDEO_FRAMERATE;

            public bool OUTPUT_USE_TIMEFRAME;
            public string OUTPUT_TIMEFRAME_START;
            public string OUTPUT_TIMEFRAME_END;
            //
        }
    }
}