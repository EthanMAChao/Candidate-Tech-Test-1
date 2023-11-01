# Candidate-Tech-Test-1
includes LongestRisingSequenceFinder and Unit tests

# LongestRisingSequenceFinder
This tool (LongestRisingSequenceFinder) is to find and exact the longest raising sequence from the given set of integers

Algorithm：


Input: An `IEnumerable<int> numbers`.
Output: An `IEnumerable<int>` representing the longest rising sequence.

Steps:

1. Initialization:
    - Convert the input `numbers` to a list named `numList` since `IEnumerable<int>` does not support direct indexing.
    - Initialize four variables: `currentStart`, `currentEnd`, `longestStart`, and `longestEnd` all set to `0`. 
       `currentStart` and `currentEnd` will track the start and end indices of the current rising sequence.
       `longestStart` and `longestEnd` will track the start and end indices of the longest rising sequence found so far.

2. Traversing the List:
    - Iterate over the list `numList` starting from the second element to the end:
      
       -- If the current number is greater than the previous number:
            - Update `currentEnd` to the current index.
            - If the length of the current sequence (from `currentStart` to `currentEnd`) is greater than the longest sequence found so far (from `longestStart` to `longestEnd`), then:
                 Update `longestStart` with the value of `currentStart`.
                 Update `longestEnd` with the value of `currentEnd`.
   
       -- If the current number is not greater than the previous number:
            - Reset `currentStart` and `currentEnd` to the current index.

4. Extracting Longest Rising Sequence:
    - After finishing the iteration, extract the subsequence from `numList` that starts at `longestStart` and ends at `longestEnd`. This subsequence represents the longest rising sequence.

# UnitTests

Test different scenarios:
1. Empty Array:
   - Input :[]
   - expected output: []
2. Single Element:
   - input; [1]
   - expected output: [1]
3. Decreasing sequence:
   - input : [8,7,6,5,4,3,2,1,-1,-2]
   - expected output: [8]
4. Increasing sequence:
   - input: [-2,-1,1,2,3,4,5,6,7,8]
   - expected output: [-2,-1,1,2,3,4,5,6,7,8]
5. More than one rasing sequence:
   - input: [-8,-11,6,9,-4,-3,-2,-1,-11,-2]
   - expected output : [-4,-3,-2,-1]

Test run screenshots 
 - command : dotnet test 
   
<img width="990" alt="Screenshot 2023-11-01 at 10 15 45 pm" src="https://github.com/EthanMAChao/Candidate-Tech-Test-1/assets/145791657/6ad7ae4d-4876-48f6-95e4-a7ac40d3409a">

   
   
   



