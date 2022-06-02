namespace BlazorServerApp.Data
{
    public class Images
    {
        public List<string> GetImages()
        {
            List<string> images = new List<string>();
            for (int i = 0; i < 10; i++)
            {

                string path = Directory.GetCurrentDirectory() + "/wwwroot/images/" + i + ".jpg";
                string path2 = "/images/" + i + ".jpg";
                if (File.Exists(path))
                {
                    images.Add(path2);
                }
            }
            return images;
        }

        public int CountFiles()
        {

            DirectoryInfo path = new DirectoryInfo(Directory.GetCurrentDirectory() + "/wwwroot/images/");

            int fileLength = path.GetFiles().Length;

            return fileLength;
        }
    }
}
