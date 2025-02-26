using DataFinder.DAL;

namespace DataFinder.BLL
{
    public class File
    {
        public Guid Id { get; }
        public string Name { get; }
        public string Path { get; }

        public File(FileEntity fileEntity)
        {
            this.Id = fileEntity.Id;
            this.Name = fileEntity.Name;
            this.Path = fileEntity.Path;
        }
    }
}
