﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StatisticsRomania.BusinessObjects;

namespace StatisticsRomania.Repository.Seeders
{
    public static class AverageGrossSalarySeeder
    {
        internal static List<AverageGrossSalary> GetData()
        {
            var rawData = new List<string>()
                                       {
                                           "Bacau 1889 1947 2089 1791 1782 1908 1903 1902 1941 1986 1971 1981 2017",
                                           "Bihor 1762 1799 1843 1771 1750 1823 1829 1823 1851 1896 1865 1901 1955",
                                           "BistritaNasaud 1816 1864 1869 1753 1731 1801 1799 1766 1794 1890 1866 1937 1981",
                                           "Botosani 1688 1705 1806 1817 1791 1819 1829 1800 1826 1871 1845 1871 1921",
                                           "Brasov 2224 2358 2431 2297 2298 2489 2414 2383 2482 2443 2406 2421 2510",
                                           "Braila 1744 1737 1847 1796 1765 1808 1853 1791 1803 1884 1830 1842 1901",
                                           "Buzau 1863 1872 2073 1867 1874 1939 1960 1938 1952 1971 1984 1998 2038",
                                           "CarasSeverin 1735 1779 1759 1745 1753 1784 1815 1826 1835 1862 1873 1898 1954",
                                           "Calarasi 1816 1823 1901 1853 1838 1941 1907 1933 1948 2053 1966 2012 2088",
                                           "Cluj 2500 2581 2655 2552 2541 2655 2767 2648 2738 2807 2709 2737 2848",
                                           "Constanta 2184 2246 2422 2319 2300 2401 2503 2443 2397 2458 2442 2481 2554",
                                           "Covasna 1713 1712 1825 1763 1731 1840 1751 1764 1785 1825 1831 1821 1877",
                                           "Dambovita 1869 1872 1967 1960 1922 2015 2069 1984 2065 2087 2048 2094 2141",
                                           "Dolj 2092 2149 2341 2268 2143 2152 2232 2150 2126 2272 2209 2211 2325",
                                           "Galati 2168 2166 2370 2225 2205 2275 2327 2245 2269 2315 2318 2305 2342",
                                           "Giurgiu 1692 1720 1840 1859 1805 1853 1939 1915 1884 1955 1906 1958 2041",
                                           "Gorj 2242 2319 2473 2320 2293 2414 2614 2371 2310 2431 2511 2434 2510",
                                           "Harghita 1565 1559 1610 1644 1643 1679 1686 1672 1713 1762 1741 1777 1827",
                                           "Hunedoara 1960 1957 2106 1999 1993 2059 2102 1997 2012 2083 2033 2039 2115",
                                           "Ialomita 1807 1797 1931 1774 1776 1845 1853 1850 1851 1865 1866 1933 1967",
                                           "Iasi 2162 2209 2290 2246 2224 2321 2308 2330 2312 2348 2353 2374 2446",
                                           "Ilfov 2724 2920 3096 2793 2809 3027 2902 2915 2906 3016 2924 2983 3007",
                                           "Maramures 1702 1750 1768 1732 1734 1799 1779 1777 1803 1892 1864 1896 1967",
                                           "Mehedinti 1951 2006 2142 1971 1948 2018 2059 2022 2001 2048 2159 2145 2088",
                                           "Mures 2052 2061 2264 2148 2197 2282 2499 2245 2281 2297 2290 2280 2341",
                                           "Neamt 1728 1708 1810 1758 1746 1801 1817 1787 1773 1811 1846 1850 1896",
                                           "Olt 1961 1990 2143 1999 1985 2165 2090 2070 2212 2172 2254 2196 2216",
                                           "Prahova 2232 2276 2372 2222 2241 2346 2331 2321 2278 2299 2287 2333 2357",
                                           "SatuMare 1873 1859 1914 1816 1823 1986 1883 1896 1903 1969 1944 1790 2045",
                                           "Salaj 2024 1859 1924 1816 1855 1868 1852 1830 1883 1981 1929 1992 2143",
                                           "Sibiu 2432 2479 2912 2558 2476 2615 2784 2691 2596 2690 2628 2655 2721",
                                           "Suceava 1701 1706 1798 1716 1641 1699 1697 1747 1708 1742 1744 1787 1822",
                                           "Teleorman 1675 1694 1716 1905 1862 1896 1906 1893 1917 1963 1972 1974 2032",
                                           "Timis 2438 2724 2738 2481 2497 2694 2690 2601 2710 2685 2585 2640 2713",
                                           "Tulcea 1984 1950 2083 1879 1858 1909 2077 1907 1948 2004 2004 1926 1973",
                                           "Vaslui 1700 1691 1747 1687 1675 1747 1773 1741 1729 1797 1775 1796 1893",
                                           "Valcea 1856 1887 1986 1909 1904 1955 2034 2005 2009 2081 2085 2078 2125",
                                           "Vrancea 1724 1711 1816 1774 1760 1833 1844 1822 1831 1890 1917 1897 1991",
                                           "Bucuresti 3271 3314 3631 3344 3329 3581 3637 3520 3494 3543 3473 3509 3539",
                                       };

            var items = new List<AverageGrossSalary>();

            foreach (var rawItem in rawData)
            {
                var data = rawItem.Split(' ');

                var county = data[0];
                var year = 2014;
                var month = 10;

                for (var i = 1; i <= 13; i++)
                {
                    var item = new AverageGrossSalary()
                                   {
                                       Subchapter = "Total judet",
                                       CountyId = CountryIds.Counties[county],
                                       Year = year,
                                       YearFraction = month,
                                       Value = float.Parse(data[i])
                                   };

                    items.Add(item);

                    month++;
                    if (month == 13)
                    {
                        year++;
                        month = 1;
                    }
                }
            }

            return items;
        }
    }
}