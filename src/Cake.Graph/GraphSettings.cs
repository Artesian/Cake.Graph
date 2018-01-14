using Cake.Graph.Generators;

namespace Cake.Graph
{
    /// <summary>
    /// Settings for creating the graph files
    /// </summary>
    public class GraphSettings
    {
        /// <summary>
        /// Root folder to deploy content to
        /// </summary>
        public string OutputPath { get; set; } = "docs/input";
        /// <summary>
        /// Path to deploy the node set files to
        /// </summary>
        public string NodeSetsPath { get; set; } = "tasks";
        /// <summary>
        /// The generator which will convert the task and dependencies to a string
        /// </summary>
        public ITaskGraphGenerator Generator { get; set; }
    }
}