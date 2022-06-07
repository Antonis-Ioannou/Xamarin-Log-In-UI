using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginApp
{
    public class HomeFlyoutFlyoutMenuItem
    {
        public HomeFlyoutFlyoutMenuItem()
        {
            TargetType = typeof(HomeFlyoutFlyoutMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}