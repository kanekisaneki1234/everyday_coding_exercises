function createGraph(num: number, prerequisites: number[][]): number[][] {
    let graph:number[][] = Array.from({length: num}, () => []);
    for (const [a,b] of prerequisites) graph[b].push(a);
    return graph;
}

function dfsCheck(graph: number[][], node: number, state: number[]): boolean {
    if (state[node]==2) return true;
    if (state[node]==1) return false;

    state[node]=1;
    for (const neighbour of graph[node]) {
        if (!dfsCheck(graph, neighbour, state)) return false;
    } state[node]=2;
    return true;
}

function isDoable(graph: number[][]): boolean {
    let state: number[] = Array.from({length : graph.length}, () => 0);
    for (let i=0; i<graph.length; i++) {
        if (!dfsCheck(graph, i, state)) return false;
    } return true;
}

{
    let graph = createGraph(4, [[1,0], [2,1], [3,0]]);

    console.log(isDoable(graph));
}