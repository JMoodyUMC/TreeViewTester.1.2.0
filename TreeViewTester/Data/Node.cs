using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace TreeViewTester.Data
{
    public class Node
    {
        public string Id { get; set; }
        public string Text { get; set; }
        public string Type { get; set; }
        public List<Node> Children { get; set; }
        public string? ParentID { get; set; }

        public Node(Int64 nId, string sType, string sText)
        {
            Id = String.Format("{0}{1}", sType, nId);
            Type = sType;
            Text = sText;
            Children = new List<Node>();
        }

        public void AddChild(Node child)
        {
            child.ParentID = Id;
            Children.Add(child);
        }
    }
}
