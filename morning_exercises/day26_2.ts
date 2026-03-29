function createGraph2(num: number, prerequisites: number[][]): number[][] {
    let graph: number[][] = Array.from({length: num}, ()=>[]);
    for (const [a,b] of prerequisites) graph[b].push(a);
    return graph;
}

function dfsCheck2(graph: number[][], node: number, state: number[], result: number[]): boolean {
    if (state[node]==2) return true;
    if (state[node]==1) return false;

    state[node]=1;
    for (let neighbour of graph[node]) {
        if (!dfsCheck2(graph, neighbour, state, result)) return false
    }
    state[node]=2;
    result.push(node);
    return true;
}

function isDoable2(graph: number[][]): number[] {
    let state: number[] = Array.from({length: graph.length}, ()=>0);
    let result: number[] = [];

    for (let i = 0; i<graph.length; i++) {
        if (!dfsCheck2(graph, i, state, result)) return [];
    }
    return result.reverse();
}

{
    let graph = createGraph2(4, [[1,0], [2,1], [3,2]]);

    console.log(isDoable2(graph));
}