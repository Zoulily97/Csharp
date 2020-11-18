namespace Csharp.文章
{
    //评价
    public class Appraise: IAgree,IDisagree
    {
        public User Voter { get; set; }
        //public T Target { get; set; }
       
        //每个文章和评论都有一个评价
        public Article Article { get; set; }
        public Comment Comment { get; set; }

        public void Agree(User voter)
        {
           
        }

        public void Disagree()
        {
            
        }
    }
}
