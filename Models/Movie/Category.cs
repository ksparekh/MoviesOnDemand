namespace MoviesOnDemand.Models
{
    public class MovieCategory
    {
        public MovieCategory() {}

        public MovieCategory(int id, string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new System.ArgumentException("Category Name can't be empty.", nameof(name));
            }

            this.ID = id;
            this.Name = name;
        }

        public int ID { get; set; }
        public string Name { get; set; }
    }
}