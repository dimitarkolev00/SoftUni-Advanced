namespace Tuple
{
    public class Tuple<Tfirst, Tsecond, Tthird>
    {
        public Tuple(Tfirst fisrtItem, Tsecond secondItem, Tthird thirdItem)
        {
            this.FirstItem = fisrtItem;
            this.SecodItem = secondItem;
            this.ThirdItem = thirdItem;
        }
        public Tfirst FirstItem { get; set; }
        public Tsecond SecodItem { get; set; }
        public Tthird ThirdItem { get; set; }
        public override string ToString()
        {
            return $"{this.FirstItem} -> {this.SecodItem} -> {this.ThirdItem}";
        }
    }
}
