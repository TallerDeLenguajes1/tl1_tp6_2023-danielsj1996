# tl1_tp6_2023-danielsj1996
# Ejercicio 4

# ¿String es una tipo por valor o un tipo por referencia?
# String es una de las variables de tipos por referencia ya que almacena referencias a sus datos (objetos).

# 
# Secuencia de escape	                    Nombre de carácter	                          Codificación Unicode
#       \'	                Comilla simple	                                                    0x0027
#       \"	                Comilla doble	                                                    0x0022
#       \\	                Barra diagonal inversa	                                            0x005C
#       \0	                Null	                                                            0x0000
#       \a	                Alerta	                                                            0x0007
#       \b	                Retroceso	                                                        0x0008
#       \f	                Avance de página	                                                0x000C
#       \n	                Nueva línea	                                                        0x000A
#       \r	                Retorno de carro	                                                0x000D
#       \t	                Tabulación horizontal	                                            0x0009
#       \v	                Tabulación vertical	                                                0x000B
#       \u	                Secuencia de escape Unicode (UTF-16)	                \uHHHH (intervalo: 0000 - FFFF; ejemplo: \u00E7 = "ç")
#       \U	                Secuencia de escape Unicode (UTF-32)	                \U00HHHHHH (intervalo: 000000 - 10FFFF; ejemplo: \U0001F47D = "👽")
#       \x	                Secuencia de escape Unicode similar a "\u" excepto con longitud variable	\xH[H][H][H] (intervalo: 0 - FFFF; ejemplo: \x00E7 o \x0E7 o \xE7 = "ç")
#  
#  
# 

# ¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?
# El carácter especial @ actúa como un identificador textual en una cadena de texto en la cual tiene que estar escrito al lado de las comillas de inicio de la oracion
# El carácter especial $ identifica un literal de cadena como una cadena interpolada. Una cadena interpolada es un literal de cadena que puede contener expresiones de interpolación.
# Cuando una cadena interpolada se resuelve en una cadena de resultado, los elementos con expresiones de interpolación se reemplazan por las representaciones de cadena de los 
# resultados de la expresión.

# La interpolación de cadenas proporciona una sintaxis más legible y conveniente de dar formato a las cadenas. Es más fácil de leer que el formato compuesto de cadenas. Compare el
# ejemplo siguiente donde se usan ambas características para producir el mismo resultado:
#
#
#

