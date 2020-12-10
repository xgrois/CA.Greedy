## Job Scheduling With Profits And Deadlines

__Problem statement__

<img src="/JobSchedulingWithProfitsAndDeadlines/problem.JPG" alt="drawing" width="800"/>

__Problem formulation__

This problem can be formally written as follows:

<img src="https://render.githubusercontent.com/render/math?math=\max_{} \sum_{i = 0}^{N-1} \sum_{j = 0}^{\min(d_i,L)} p_i x_{i,j}">

subject to:

<img src="https://render.githubusercontent.com/render/math?math=x_i \in \{0,1\}">

__Examples of greedy algorithms__

Example of a naive sequential algorithm:

<img src="/JobSchedulingWithProfitsAndDeadlines/example_sequential.JPG" alt="drawing" width="800"/>

__Difficulty in literature__

This problem is considered Medium in literature.

__References__

[[1]](https://www.techiedelight.com/greedy-coloring-graph/) Graph Coloring Problem, Techie Delight.

## Output

Examples of the coded greedy algorithm.
First, sort jobs by profit.
Then, traverse sorted jobs sequentially and schedule a job to its most latest available slot.

<img src="/JobSchedulingWithProfitsAndDeadlines/examples.JPG" alt="drawing" width="800"/>

<img src="/JobSchedulingWithProfitsAndDeadlines/output.JPG" alt="drawing" width="800"/>

