
![image](https://github.com/user-attachments/assets/84a47e61-dbb0-4f5d-ae8c-226203b2bb15)


# Explication de l'Algorithme de Newton-Raphson pour Calculer la Racine n-ième

L'algorithme de Newton-Raphson est une méthode itérative pour trouver une approximation numérique des **racines d'une fonction** (c'est-à-dire les solutions de \( f(x) = 0 \)).  
Dans le cas du calcul de la **racine n-ième** d'un nombre \( \text{number} \), on cherche \( x \) tel que :  
![image](https://github.com/user-attachments/assets/924cb23e-5593-48c7-b62d-b15d56b1ef54)


---

### **Formule Itérative (Newton-Raphson)**
La formule de mise à jour est :  
![image](https://github.com/user-attachments/assets/cb80c860-4e80-4adb-a23b-d4ee59884134)

où :
![image](https://github.com/user-attachments/assets/edef8e18-24a8-4124-a5e5-3c6b2b2f35e7)


En substituant, on obtient la formule utilisée dans l'exercice :  
![image](https://github.com/user-attachments/assets/a3cfda85-eb6e-44d9-9486-d627ade702c4)


---

### **Étapes de l'Algorithme**
1. **Estimation initiale** :  
   - On part d'une valeur arbitraire (par exemple, \( x = \text{number} \)).

2. **Itération** :  
   - À chaque étape, on calcule une nouvelle approximation \( x_{\text{new}} \) en utilisant la formule ci-dessus.

3. **Critère d'arrêt** :  
   - On s'arrête quand la différence entre deux itérations est inférieure à une tolérance \( \epsilon \) (ex: \( \epsilon = 10^{-6} \)).  
  ![image](https://github.com/user-attachments/assets/2045fadd-edbd-466f-b923-2d6d358d1f24)

---

### **Exemple avec la Racine Carrée (n=2)**
![image](https://github.com/user-attachments/assets/c709bf36-0fbc-4625-a7eb-f821129243aa)

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
  


![image](https://github.com/user-attachments/assets/bb83b67e-317e-4fc5-b790-62e2a906f760)


