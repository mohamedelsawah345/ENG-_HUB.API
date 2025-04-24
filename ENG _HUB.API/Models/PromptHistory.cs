namespace ENG__HUB.API.Models
{
    public class PromptHistory
    {
        public int PromptHistoryID { get; set; }
        public string PromptText { get; set; }

        public int UserID { get; set; }
        public User User { get; set; }
    }

}
