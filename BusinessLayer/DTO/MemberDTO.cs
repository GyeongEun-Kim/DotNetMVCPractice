namespace BusinessLayer.DTO
{
    public class MemberDTO
    {
        public int Id { get; set; }  
        public string Name { get; set; }
        public string Company { get; set; }
        public string Grade { get; set; }
        public int Age { get; set; }
        public DateTime CreDateTime { get; set; }   
        public DateTime? ModDateTime { get; set; }
    }
}
