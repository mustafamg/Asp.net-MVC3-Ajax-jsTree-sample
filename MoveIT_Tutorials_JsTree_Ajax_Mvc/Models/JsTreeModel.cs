using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MoveIT_Tutorials_JsTree_Ajax_Mvc.Models
{
    public class TreeViewItemModel
    {
        public TreeViewItemModelData data { get; set; }
        public string state { get; set; } //'open' to display node children when loaded, 'closed' to make an AJAX call to retrieve the children, 'string.empty' to not display the child nodes when loaded and do not make ajax calls to get the children
        public TreeViewItemModelAttributes attr { get; set; }
        //public List<TreeViewItemModel> children { get; set; }
    }

    public class TreeViewItemModelData
    {
        public string title { get; set; } //text do be displayed in the node
        public string icon { get; set; } //remove this property if not wanting to customize node icon

    }

    public class TreeViewItemModelAttributes
    {
        public string id { get; set; }
        public string other_attribute { get; set; }
    }

}