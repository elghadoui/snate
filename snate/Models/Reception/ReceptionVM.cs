namespace snate.Models.Reception
{
    public class ReceptionVM
    {
        public List<Reception>? receptionslst { get; set; }
        public Tvnrecap? TvnrecapList { get; set; } = default(Tvnrecap?);
        public List<RecapReception>? RecapReceptionlst { get; set; }
    }
}
