# Explication de l'Algorithme de Newton-Raphson pour Calculer la Racine n-ième

L'algorithme de Newton-Raphson est une méthode itérative pour trouver une approximation numérique des **racines d'une fonction** (c'est-à-dire les solutions de \( f(x) = 0 \)).  
Dans le cas du calcul de la **racine n-ième** d'un nombre \( \text{number} \), on cherche \( x \) tel que :  
\[
x^n = \text{number} \quad \Rightarrow \quad f(x) = x^n - \text{number} = 0.
\]

---

### **Formule Itérative (Newton-Raphson)**
La formule de mise à jour est :  
\[
x_{\text{new}} = x - \frac{f(x)}{f'(x)}
\]  
où :
- \( f(x) = x^n - \text{number} \) (la fonction dont on cherche la racine),
- \( f'(x) = n \cdot x^{n-1} \) (sa dérivée).

En substituant, on obtient la formule utilisée dans l'exercice :  
\[
x_{\text{new}} = x - \frac{x^n - \text{number}}{n \cdot x^{n-1}}.
\]

---

### **Étapes de l'Algorithme**
1. **Estimation initiale** :  
   - On part d'une valeur arbitraire (par exemple, \( x = \text{number} \)).

2. **Itération** :  
   - À chaque étape, on calcule une nouvelle approximation \( x_{\text{new}} \) en utilisant la formule ci-dessus.

3. **Critère d'arrêt** :  
   - On s'arrête quand la différence entre deux itérations est inférieure à une tolérance \( \epsilon \) (ex: \( \epsilon = 10^{-6} \)).  
   - Cela signifie que \( |x_{\text{new}} - x| < \epsilon \).

---

### **Exemple avec la Racine Carrée (n=2)**
**Problème** : Trouver \( \sqrt{25} \) (i.e., \( \text{number} = 25 \), \( n = 2 \)).  
- **Fonction** : \( f(x) = x^2 - 25 \),  
- **Dérivée** : \( f'(x) = 2x \).  

**Itérations** :
1. \( x_0 = 25 \) (estimation initiale).  
   \[
   x_1 = 25 - \frac{25^2 - 25}{2 \cdot 25} = 25 - \frac{625 - 25}{50} = 25 - 12 = 13.
   \]
2. \( x_1 = 13 \).  
   \[
   x_2 = 13 - \frac{13^2 - 25}{2 \cdot 13} = 13 - \frac{169 - 25}{26} \approx 13 - 5.538 \approx 7.462.
   \]
3. \( x_3 \approx 7.462 - \frac{7.462^2 - 25}{2 \cdot 7.462} \approx 5.406 \).  
4. \( x_4 \approx 5.406 - \frac{5.406^2 - 25}{2 \cdot 5.406} \approx 5.016 \).  
5. \( x_5 \approx 5.016 - \frac{5.016^2 - 25}{2 \cdot 5.016} \approx 5.000 \).  

**Résultat** : La suite converge vers \( 5 \) (la racine exacte).

---

### **Pourquoi ça Marche ?**
- L'algorithme utilise la **tangente** à la courbe \( f(x) \) pour approximer la racine.  
- À chaque itération, l'approximation se rapproche de la solution vraie (sous certaines conditions de régularité de \( f \)).

---

### **Applications**
- Calcul de racines (carrées, cubiques, etc.).  
- Résolution d'équations non linéaires.  
- Optimisation (recherche de minima/maxima).

---

### **Remarques**
1. **Convergence rapide** :  
   - Généralement quadratique (le nombre de chiffres précis double à chaque itération).  
2. **Sensibilité à l'initialisation** :  
   - Une mauvaise estimation initiale peut conduire à une divergence.  
3. **Cas pathologiques** :  
   - Éviter \( x = 0 \) (dérivée nulle).  
