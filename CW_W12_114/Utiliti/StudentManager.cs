namespace CW_W12_114.Utiliti
{
    public static class StudentManager
    {
        public static List<Student> FilterStudent(this List<Student> students,int id)
        {
            students = students.Where(x => x.Id%id==0).ToList();
            return students;
        }

    }
}
