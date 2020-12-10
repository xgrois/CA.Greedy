## Job Scheduling With Profits And Deadlines

__Problem statement__

<img src="/JobSchedulingWithProfitsAndDeadlines/problem.JPG" alt="drawing" width="800"/>

There are a few greedy algorithms to tackle this problem. Beyond the general fast behavior of greedy algorithms,
the good thing is that they are also optimal in this case (they find the optimal solution).

Note, however, that these algorithms are proven to be optimal only when all tasks can be completed in a unit of time (or slot).
When each task can last 1 or more slots, the problem is more challeging and these solutions will not work anymore.

__Problem formulation__

This problem can be formally written as follows:

<img src="https://render.githubusercontent.com/render/math?math=\max_{} \sum_{i = 0}^{N-1} \sum_{j = 0}^{\min(d_i,L)} p_i x_{i,j}">

subject to:

<img src="https://render.githubusercontent.com/render/math?math=x_i \in \{0,1\}">

where:

<img src="https://render.githubusercontent.com/render/math?math=d_i"> is the deadline of job i (positive integer >= 1).

<img src="https://render.githubusercontent.com/render/math?math=p_i"> is the profit of job i (positive integer >= 0).

<img src="https://render.githubusercontent.com/render/math?math=x_{i,j}"> binary variable defines the schedule (0 or 1).

<img src="https://render.githubusercontent.com/render/math?math=L"> is the maximum length of the schedule (positive integer >= 0).

Note that each job takes 1 slot to complete always.

__Examples of greedy algorithms__

Example of a naive sequential algorithm:

<img src="/JobSchedulingWithProfitsAndDeadlines/example_sequential.JPG" alt="drawing" width="800"/>

__Difficulty in literature__

This problem is considered Medium in literature.

__References__

[[1]](https://www.techiedelight.com/job-sequencing-problem-deadlines/) Job Sequencing Problem with Deadlines, Techie Delight.

[[2]](https://ocw.mit.edu/courses/civil-and-environmental-engineering/1-204-computer-algorithms-in-systems-engineering-spring-2010/lecture-notes/MIT1_204S10_lec10.pdf) 1.204 Lecture 10, Greedy algorithms: Knapsack (capital budgeting) and Job Scheduling, MIT.

[[3]](http://www.cs.mun.ca/~kol/courses/6783-w13/lec3.pdf) Lecture 3, Applied Algorithms, CS 6783.


## Greedy Algorithm 1

__Runtime Complexity__

O(n^2)

__Description__

First, sort jobs by profit.
Then, traverse sorted jobs sequentially and schedule a job to its most latest available slot.

<img src="/JobSchedulingWithProfitsAndDeadlines/examples.JPG" alt="drawing" width="800"/>

<img src="/JobSchedulingWithProfitsAndDeadlines/output.JPG" alt="drawing" width="800"/>

## Greedy Algorithm 2 (Union-Find improvement)

__Runtime Complexity__

O(n log n) because the algorithm is dominated by the sorting time.
The Union-Find (to assign the latest available slot to a job) is O(1) in average.

__Description__

First, sort jobs by profit.
Then, traverse sorted jobs sequentially and schedule a job to its most latest available slot.

However, instead of traversing all slots from right to left until we get a free slot, 
in this algorithm we use the Union-Find data structure (a.k.a. Disjoint Sets) to do that.

This change will improve the runing time of the algorithm.

Below is an illustration of the algorithm:

<img src="/JobSchedulingWithProfitsAndDeadlines/union_find.JPG" alt="drawing" width="800"/>

<img src="/JobSchedulingWithProfitsAndDeadlines/example_union_find.JPG" alt="drawing" width="800"/>

