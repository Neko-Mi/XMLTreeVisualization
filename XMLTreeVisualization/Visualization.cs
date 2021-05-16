using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace XMLTreeVisualization
{
    class Visualization
    {
        /// <summary>
        /// Visualization XML file in treeView
        /// </summary>
        /// <param name="treeView">treeView form where will visualisation tree</param>
        /// <param name="filePath">Path to XML file</param>
        public void Visualize(TreeView treeView, String filePath) 
        {
            XDocument doc = new();
            try
            {
                doc = XDocument.Load(filePath);
                treeView.Nodes.Clear();
                TreeTraversal(treeView.Nodes, doc.Root);
                treeView.ExpandAll();
            }
            catch (Exception e)
            {
                MessageBox.Show("XML are not correct");
            }
            
        }

        /// <summary>
        /// Traversal xml tree elements and values
        /// </summary>
        /// <param name="nodes">the node we go around</param>
        /// <param name="element">the element we go around</param>
        private void TreeTraversal(TreeNodeCollection nodes, XElement element)
        {
            if (element.HasElements)
            {
                TreeNode node = nodes.Add(element.Name.LocalName);
                
                foreach (XElement elem in element.Elements())
                {
                    TreeTraversal(node.Nodes, elem); 
                }
            }
            else
            {
                TreeNode node = nodes.Add(element.Name.LocalName);
                
                if (!element.Value.Equals(""))
                {
                    node.Nodes.Add(element.Value);
                }
            }
        }
        
    }
}
