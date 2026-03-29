class GraphNode {
    constructor (
        public val: number = 0,
        public neighbours: GraphNode[] = []
    ) {}

    static cloneGraphHelper(node: GraphNode | null, map: Map<GraphNode, GraphNode>): GraphNode | null {
        if (node == null) return null;
        // if (node.neighbours.length === 0) return new GraphNode(node.val);

        if (map.has(node)) return map.get(node)!;

        const clone = new GraphNode(node.val);
        map.set(node, clone);

        for (const neighbour of node.neighbours) {
            clone.neighbours.push(GraphNode.cloneGraphHelper(neighbour, map)!);
        }
        return clone;
    }

    static cloneGraph(node: GraphNode | null): GraphNode | null {
        let map = new Map<GraphNode, GraphNode>();
        return GraphNode.cloneGraphHelper(node, map);
    }
}

{
    const node = new GraphNode(1);
    const node2 = new GraphNode(2);
    const node3 = new GraphNode(3);
    const node4 = new GraphNode(4);

    node.neighbours = [node2, node4];
    node2.neighbours = [node3, node];
    node3.neighbours = [node4, node2];
    node4.neighbours = [node, node3];

    console.log(GraphNode.cloneGraph(node)?.neighbours[0].neighbours[0].neighbours[0]);
}