using System;
using System.Collections.Generic;
using System.Text;

namespace CountNodes
{
    class TreeNode
    {
        public String nodeName { get; set; }
        public List<TreeNode> childNodes { get; set; }

        public TreeNode(String name)
        {
            nodeName = name;
            childNodes = new List<TreeNode>();
        }
    }
}
