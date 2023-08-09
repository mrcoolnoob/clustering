clusters = []
delivery_point = ["a", "b", "c", "d", "e"]

for i, each in enumerate(delivery_point):
    clusters.append([each])
    # print(clusters)
    for each_r in delivery_point:
        if each != each_r:
            # print(each + " "+ each_r)
            # print(dis)
            if len(clusters[i]) == 1:
                dis = eval(input(f"Enter distance b/w {each} & {each_r}: " ))
                if dis <=8:
                    clusters[i].append(each_r)
            else:
                print(clusters)
                passed = True
                for element in clusters[i]:
                    dis = eval(input(f"Enter distance b/w {element} & {each_r}: " ))
                    if dis > 8:
                        passed = False
                        break
                if passed:
                    clusters[i].append(each_r)
