Jiao et al.(2006) apply this method to linearchain CRFs and demonstrate encouraging accuracy improvements on a gene-name-tagging task.
P06-1027
Kim et al.(2006) propose using entropy as a confidence estimator in active learning in CRFs, where examples with the most uncertainty are selected for presentation to humans labelers.
N06-2018
We present here an alternative derivation of the gradient: ∂ ∂θk −H(Y|x) = ∂ ∂θk X Y pθ(Y|x)logpθ(Y|x) = X Y „ ∂ ∂θk pθ(Y|x) « logpθ(Y|x) + pθ(Y|x) „ ∂ ∂θk logpθ(Y|x) « = X Y pθ(Y|x)logpθ(Y|x) × Fk(x,Y ) − X Y prime pθ(Y prime|x)Fk(x,Y prime) ! + X Y pθ(Y|x) Fk(x,Y ) − X Y prime pθ(Y prime|x)Fk(x,Y prime) !. Since summationtextY pθ(Y |x)summationtextY prime pθ(Y prime|X)Fk(x,Y prime) =summationtext Y prime pθ(Y prime|X)Fk(x,Y prime), the second summand cancels, leaving: ∂ ∂θ −H(Y|x) = X Y pθ(Y|x)logpθ(Y|x)Fk(x,Y ) − X Y pθ(Y|x)logpθ(Y|x) ! X Y prime pθ(Y prime|x)Fk(x,Y prime) ! . Like the gradient obtained by Jiao et al.(2006), there are two terms, and the second is easily computable given the feature expectations obtained by 110 forward/backward and the entropy for the sequence.
P06-1027
Jiao et al.(2006) perform this computation by: ∂ ∂θ − H(Y |x) = covpθ(Y |x)[F(x,Y )]θ, where covpθ(Y |x)[Fj(x,Y ),Fk(x,Y )] = Epθ(Y |x)[Fj(x,Y ),Fk(x,Y )] −Epθ(Y |x)[Fj(x,Y )]Epθ(Y |x)[Fk(x,Y )].
P06-1027
The complete asymptotic computational cost of calculating the entropy gradient is O(ns2), which is the same time as supervised training, and a factor of O(ns) faster than the method proposed by Jiao et al.(2006). Wall clock timing experiments show that this method takes approximately 1.5 times as long as traditional supervised training—less than the constant factors would suggest.1 In practice, since the three extra dynamic programs do not require recalculation of the dot-product between parameters and input features (typically the most expensive part of inference), they are significantly faster than calculating the original forward/backward lattice.
P06-1027