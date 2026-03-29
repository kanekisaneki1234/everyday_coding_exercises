from __future__ import annotations

class GraphNode:
    def __init__(self, val=0):
        self.val = val
        self.neighbours = []

    @staticmethod
    def cloneGraphHelper(node: GraphNode | None, map: dict)->GraphNode | None:
        if node is None: return None
        # if node.neighbours == []: return GraphNode(node.val)

        if node in map: return map[node]

        clone = GraphNode(node.val)
        map[node]=clone
        # return clone
        
        for neighbour in node.neighbours: clone.neighbours.append(GraphNode.cloneGraphHelper(neighbour, map))
        return clone
    
    @staticmethod
    def cloneGraphNode(node: GraphNode | None)->GraphNode | None:
        map = {}
        return GraphNode.cloneGraphHelper(node, map)
    
node = GraphNode(1)
node2 = GraphNode(2)
node3 = GraphNode(3)
node4 = GraphNode(4)

node.neighbours = [node2, node4]
node2.neighbours = [node3, node]
node3.neighbours = [node4, node2]
node4.neighbours = [node, node3]

print(GraphNode.cloneGraphNode(node).neighbours[0].neighbours[0].neighbours[0].neighbours[0].val)