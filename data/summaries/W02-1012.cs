A basic bigram HMM-based model gives us a29a25a1a19a32a50a8a30a98a13a85a33 a34 a102a80a109a110 a11 a91 a22a93a92 a7a20a111 a29a2a1a19a82a15a22a50a8a82a15a22a23a24 a7 a40 a27 a13a46a29a2a1a4a10a84a22a50a8a3a16a102a44a103a9a13a113a112 (2) In this HMM model,2 alignment probabilities are independent of word position and depend only on jump width (a82a6a22a115a114a116a82a9a22a23a24 a7 ).3 The Och and Ney (2000a) model includes refinements including special treatment of a jump to Null and smoothing with a uniform prior which we also included in our initial model.
C00-2163 P00-1056
In this paper we present extensions to the HMM alignment model of (Vogel et al., 1996; Och and Ney, 2000b).
C00-2163 C96-2141 P00-1056
Brown et al.(1993) and Och et al.(1999) variably condition this probability on the English word in position a82a9a22a23a24 a7 and/or the French word in position a104 . As conditioning directly on words would yield a large number of parameters and would be impractical, they cluster the words automatically into bilingual word classes.
J93-2003 W99-0604
It has been shown (Vogel et al., 1996; Och et al., 1999; Och and Ney, 2000a) that HMM based alignment models are effective at capturing such localization.
C00-2163 C96-2141 P00-1056 W99-0604
Our test data consists of a191 a179a6a179 manually aligned sentences which are the same data set used by (Och and Ney, 2000b).6 In the annotated sentences every alignment between two words is labeled as either a sure (S) or possible (P) alignment.
C00-2163 P00-1056
We use as a baseline the model presented by (Och and Ney, 2000a).
C00-2163 P00-1056
The main task in statistical machine translation is to model the string translation probability a0a2a1a4a3a6a5a7a9a8a10a12a11a7a14a13 where the string a10 a11a7 in one language is translated into another language as string a3a15a5a7. We refer to a3a16a5a7 as the source language string and a10 a11a7 as the target language string in accordance with the noisy channel terminology used in the IBM models of (Brown et al., 1993).
J93-2003
Melamed (2000) uses a very broad classification of words (content, function and several punctuation classes) to estimate class-specific parameters for translation models.
J00-2004
a29a145a177 a90 a33a88a29a2a1a19a82a9a22a146a33a178a106a122a8a82a15a22a23a24 a7 a33a178a106a42a40 a27 a13 . 5.4 Translation Model for Null As originally proposed by Brown et al.(1993), words in the target sentence for which there are no corresponding English words are assumed to be generated by the special English word Null.
J93-2003
Many alignment models assume a one to many mapping from source language words to target language words, such as the IBM models 1-5 of Brown et al.(1993) and the HMM alignment model of (Vogel et al., 1996).
C96-2141 J93-2003
It has required many special fixes to keep models from aligning everything to Null or to keep them from aligning nothing to Null (Och and Ney, 2000b).
C00-2163 P00-1056
Och is the HMM alignment model of (Och and Ney, 2000b).
C00-2163 P00-1056
For example, if we use the following conditioning information: a29a2a1a19a82 a22 a8a82 a22a23a24 a7 a7 a40a80a10 a22a23a24 a7 a7 a40a80a10a41a81 a22a84a24 a7 a7 a40 a28 a40a42a30a41a40a42a30a50a43a26a13a115a33 a29a2a1a19a82a9a22a74a8a82a15a22a23a24 a7 a40a80a3a122a81a31a102a44a103a42a131 a110 a24 a7 a40a80a3a84a81a55a102a46a103a107a131 a110 a40a80a3a122a81a31a102a44a103a42a131 a110a46a155 a7 a13 we could model probabilities of transpositions and insertion of function words in the target language that have no corresponding words in the source language (a3a16a102a46a103 is Null) similarly to the channel operations of the (Yamada and Knight, 2001) syntaxbased statistical translation model.
P01-1067
We used the following quantity (called alignment error rate or AER) to evaluate the alignment quality of our models, which is also the evaluation metric used by (Och and Ney, 2000b): a193 a3a23a194a122a82 a27a19a27 a33 a8a195a166a196a45a197a86a8 a8a54a197a198a8 a17 a193 a3a23a194a93a106a44a199a16a106a113a200a15a201a202a33 a8a195a39a196a159a0a25a8 a8a195a26a8 a195a85a203a140a204a205a33 a8a195a166a196a159a0a25a8a23a150a77a8a195a166a196a57a197a198a8 a8a195a26a8a23a150a77a8a54a197a198a8 We divided this annotated data into a validation set of a144a84a179a6a179 sentences and a final test set of a119a47a179a6a179 sentences.
C00-2163 P00-1056
Melamed. 2000.
J00-2004