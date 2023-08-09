clusters = []
delivery_point = ["a", "b", "c", "d", "e", "f", "g"]
distance_dict = {}  # Our treasure chest for distances

for i, each in enumerate(delivery_point):
    clusters.append([each])
    for each_r in delivery_point:
        if each != each_r:
            if len(clusters[i]) == 1:
                if (each, each_r) not in distance_dict:  # Haven't calculated this distance yet
                    dis = eval(input(f"Enter distance b/w {each} & {each_r}: "))
                    distance_dict[(each, each_r)] = dis  # Store the distance
                else:
                    dis = distance_dict[(each, each_r)]  # Retrieve distance from the treasure chest
                if dis <= 8:
                    clusters[i].append(each_r)
            else:
                passed = True
                for element in clusters[i]:
                    if (element, each_r) not in distance_dict:  # Not calculated yet
                        dis = eval(input(f"Enter distance b/w {element} & {each_r}: "))
                        distance_dict[(element, each_r)] = dis  # Store the distance
                    else:
                        dis = distance_dict[(element, each_r)]  # Retrieve distance
                    if dis > 8:
                        passed = False
                        break
                if passed:
                    clusters[i].append(each_r)

print("final result")
print(clusters)
