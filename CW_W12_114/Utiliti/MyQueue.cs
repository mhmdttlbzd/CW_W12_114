namespace CW_W12_114.Utiliti
{
    public class MyQueue<T> where T : Student 
    {
        public List<T> list = new List<T>();
        public MyQueue()
        {
        }
        public List<T> SetDefaultStudents () {
            for (int i = 0; i < 100; i++)
            {
                var s = new Student("student"+i, "lastname for student"+i);
                s.Id = i;
                list.Add(s as T);
            }
            return list;
        }
        public void EnQueue(T item)
        {
            list.Add(item);
        }
        public T? DeQueue()
        {
            var temp = list.FirstOrDefault();
            if (temp != null)
            {
                list.Remove(temp);
            }
            return temp;
        }
        public List<T> SearchByFirstName(string firstName)
        {
            return list.Where(x => x.FirstName == firstName).ToList();
        }
        public List<string> GetLastNameByFirstName(string firstName)
        {
            return list.Where(x => x.FirstName == firstName).Select(x => x.GetFullName()).ToList();
            
        }
        public T GetById(int id) => list.First(x => x.Id == id);

        public bool x(T item, string firstName)
        {
            return item.FirstName == firstName;
        }
    }


}
