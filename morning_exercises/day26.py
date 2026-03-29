def courseSchedule(numCourses: int, prerequisites: list):
    graph=[[] for _ in range(numCourses)]
    for a, b in prerequisites:
        graph[b].append(a)
    return graph

def dfsCheck(graph: list, node: int, state: list)->bool:
    if state[node]==2: return True
    if state[node]==1: return False

    state[node]=1
    for req in graph[node]:
        if not dfsCheck(graph, req, state): return False
    state[node]=2
    return True

def isDoable(graph):
    state = [0 for _ in range(len(graph))]
    for i in range(0, len(graph)):
        if not dfsCheck(graph, i, state): return False
    return True

courseschedule = courseSchedule(3, [[1,0], [2,1]])
print(isDoable(courseschedule))