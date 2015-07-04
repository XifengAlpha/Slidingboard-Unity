## Cayley-graph based room naming scheme

Every room x has five exits:
* x' - inverse, back toward hub
* xL - left goal
* xR - right goal
* xW - west (cw) traverse
* xE - east (ccw) traverse

The Hub is represented by the empty string.
Every room has a canonical name consisting only of Ls and Rs.
Any route with W, E, and ' is equivalent to some route in the free
monoid on two generators.

From the hub, and every room thereafter, the two "goal exits" add
either one L or one R to the address.

Those exits each lead to the entrance of their respective rooms.
Going back through this entrance drops the last letter of the address.

    xL' = x
    xR' = x

Going through a traversal exit moves to the opposite traversal exit in
a different room with the same length of address.

The traversal exits in the hub each lead to the other:
    ^Ex = x
    ^Wx = x

Taken together, these create circuits around one level of the tree:
        LRR---RLL
       / |     | \
    LRL-LR-----RL-RLR
     |  | \   / | |
     |  | L-H-R | |
     |  | /   \ | |
    LLR-LL-----RR-RRL
       \ |     | /
        LLL---RRR
        
Two of these equivalences affect only a single L or R:
    xLW = xR
    xRE = xL

The other two involve a carry:
    xLE = xER
    xRW = xWL


    LLLW = LLR
    LLLE = LLER
         = LERR
         = ERRR
         = RRR
    RLRE = RLL
    RLRW = RLWL
         = RRL

These equivalences are sufficient to determine the end-point of any
route starting from the hub, even one that has more complicated combinations:

LLERW' = LERRW'
       = ERRRW'
       = RRRW'
       = RRWL'
       = RWLL'
       = WLLL'
       = LLL'
       = LL