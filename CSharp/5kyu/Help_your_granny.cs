using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Tour
        {
            public static int tour(string[] arrFriends, string[][] ftwns, Hashtable h)
            {
                double[] dist = new double[arrFriends.Length];
                for (int i = 0; i < arrFriends.Length; i++)
                    for (int j = 0; j < ftwns.Length; j++)
                        if (ftwns[j][0] == arrFriends[i])
                        {
                            dist[i] = (double)h[ftwns[j][1]];
                            break;
                        }
                double output = dist[0];
                for (int i = 1; i < dist.Length; i++)
                    if (dist[i] != 0)
                        output += Math.Sqrt(dist[i] * dist[i] - dist[i - 1] * dist[i - 1]);
                for (int i = dist.Length - 1; i >= 0; i--)
                    if (dist[i] != 0)
                    {
                        output += dist[i];
                        break;
                    }
                return (int)output;
            }
        }
        
