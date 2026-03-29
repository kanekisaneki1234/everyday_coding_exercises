from collections import deque

def createGraph(number: int, prerequisites: list)->list:
    graph = [[] for _ in range(0, number)]
    for a,b in prerequisites: graph[b].append(a)
    return graph

def dfsCheck(graph: list, node: int, state: list, result: deque)->bool:
    if state[node]==2: return True
    if state[node]==1: return False

    state[node]=1
    for neighbour in graph[node]:
        if not dfsCheck(graph, neighbour, state, result): return False
    state[node]=2
    result.appendleft(node)
    return True

def isDoable(graph: list)->deque:
    state = [0 for _ in range(len(graph))]
    result = deque()
    for i in range(len(graph)):
        if not dfsCheck(graph, i, state, result): return deque()
    return result

courseschedule = createGraph(2, [[1,0], [0,1]])
print(isDoable(courseschedule))