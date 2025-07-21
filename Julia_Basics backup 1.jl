{
 "cells": [
  {
   "cell_type": "markdown",
   "id": "0d2af15a-e7ed-4fc7-908a-b3c97f660ad7",
   "metadata": {},
   "source": [
    "#### LOOPS and CONDITIONS in JULIA"
   ]
  },
  {
   "cell_type": "code",
   "execution_count": 12,
   "id": "328a522e-6d14-43c1-9aed-20cccaee76f7",
   "metadata": {},
   "outputs": [
    {
     "name": "stdout",
     "output_type": "stream",
     "text": [
      "Vector{Any}\n",
      "Tuple{Int64, Int64, Int64, String}\n"
     ]
    }
   ],
   "source": [
    "# a = \"Tim\"\n",
    "# b = \"John\"\n",
    "# println(\"$a\"*\" \"*\"$b\")\n",
    "\n",
    "a=4.0\n",
    "typeof(a)\n",
    "\n",
    "array = [1,2,'3',4]\n",
    "tup = (1,2,3,\"4.0\")\n",
    "println(typeof(array))\n",
    "println(typeof(tup))\n",
    "\n"
   ]
  },
  {
   "cell_type": "code",
   "execution_count": 14,
   "id": "f445f4b0-7f04-4973-8b59-a1affd315e3c",
   "metadata": {},
   "outputs": [
    {
     "name": "stdout",
     "output_type": "stream",
     "text": [
      "-5 is less than 0\n"
     ]
    }
   ],
   "source": [
    "x=-5\n",
    "if x > 0\n",
    "    println(\"$x is greater than 0\")\n",
    "elseif x < 0\n",
    "    println(\"$x is less than 0\")\n",
    "else\n",
    "    println(\"$x is equal to 0\")\n",
    "end"
   ]
  },
  {
   "cell_type": "code",
   "execution_count": 17,
   "id": "281083fa-521b-4334-8afb-41ddb68322eb",
   "metadata": {},
   "outputs": [
    {
     "name": "stdout",
     "output_type": "stream",
     "text": [
      "4 is greater than 0\n"
     ]
    }
   ],
   "source": [
    "x=4\n",
    "# This is using Ternery Operator\n",
    "x > 0 ? println(\"$x is greater than 0\") : x < 0 ? println(\"$x is less than 0\") : println(\"$x is equal to 0\")"
   ]
  },
  {
   "cell_type": "code",
   "execution_count": 20,
   "id": "97b2daf1-3c70-4130-8304-11cdabebf149",
   "metadata": {},
   "outputs": [
    {
     "name": "stdout",
     "output_type": "stream",
     "text": [
      "This my first loop in Julia. Running it 1 times\n",
      "This my first loop in Julia. Running it 2 times\n",
      "This my first loop in Julia. Running it 3 times\n"
     ]
    }
   ],
   "source": [
    "# For loops\n",
    "x=3\n",
    "for i in 1:x\n",
    "    println(\"This my first loop in Julia. Running it $i times\")\n",
    "end"
   ]
  },
  {
   "cell_type": "code",
   "execution_count": 33,
   "id": "ab6cb306-3b99-488a-be8a-1e1bd0a68052",
   "metadata": {},
   "outputs": [
    {
     "name": "stdout",
     "output_type": "stream",
     "text": [
      "While loop here. Running 2 time(s)\n",
      "While loop here. Running 1 time(s)\n",
      "While loop here. Running 1 time(s)\n",
      "While loop here. Running 0 time(s)\n"
     ]
    }
   ],
   "source": [
    "# While Loop\n",
    "n=4\n",
    "while n > 0\n",
    "    println(\"While loop here. Running $(n÷2) time(s)\")\n",
    "    n-=1\n",
    "end"
   ]
  },
  {
   "cell_type": "code",
   "execution_count": 41,
   "id": "fc0b4c7e-3b3c-4eb5-828d-43f4d0475bad",
   "metadata": {},
   "outputs": [
    {
     "name": "stdout",
     "output_type": "stream",
     "text": [
      "90\n"
     ]
    },
    {
     "data": {
      "text/plain": [
       "101"
      ]
     },
     "execution_count": 41,
     "metadata": {},
     "output_type": "execute_result"
    }
   ],
   "source": [
    "# Functions in Julia\n",
    "function add(x,y)\n",
    "    op = x + y\n",
    "    return op\n",
    "end\n",
    "\n",
    "function mod(x,y)\n",
    "    op = x % y\n",
    "    return op\n",
    "end\n",
    "\n",
    "println(add(mod(15,4), 87))\n",
    "\n",
    "# Anonymous functions in Julia\n",
    "\n",
    "((f,g) -> (f^2 * g+69))(4,2)"
   ]
  },
  {
   "cell_type": "code",
   "execution_count": 46,
   "id": "94950811-51ac-4499-b67f-f56d6f62e24b",
   "metadata": {},
   "outputs": [
    {
     "data": {
      "text/plain": [
       "4-element Vector{Int64}:\n",
       " 1\n",
       " 2\n",
       " 3\n",
       " 4"
      ]
     },
     "execution_count": 46,
     "metadata": {},
     "output_type": "execute_result"
    }
   ],
   "source": [
    "# Array ops\n",
    "A = [1,2,3,4]\n",
    "\n",
    "# push!(A,5)\n",
    "# pop!(A)\n",
    "# deleteat!(A,1)"
   ]
  },
  {
   "cell_type": "code",
   "execution_count": 49,
   "id": "9c134b1e-fb5f-4816-b2a9-92f02c4a80b3",
   "metadata": {},
   "outputs": [
    {
     "name": "stdout",
     "output_type": "stream",
     "text": [
      "20"
     ]
    }
   ],
   "source": [
    "dict = Dict(\"Sam\" => 20, \"Tim\" => 22, \"John\" => 55)\n",
    "print(dict[\"Sam\"])\n",
    "\n",
    "set1 = Set([1,2,3,4])\n",
    "set2 = Set([1,2,3,10])\n",
    "\n",
    "# Operations on Sets\n",
    "# Union, Intersection, SetDiff"
   ]
  }
 ],
 "metadata": {
  "kernelspec": {
   "display_name": "Julia 1.11.6",
   "language": "julia",
   "name": "julia-1.11"
  },
  "language_info": {
   "file_extension": ".jl",
   "mimetype": "application/julia",
   "name": "julia",
   "version": "1.11.6"
  }
 },
 "nbformat": 4,
 "nbformat_minor": 5
}
