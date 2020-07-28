class QuickStart {
    public static void main(String[] args) {
        String test = reverseString("Hello, World.");
        
        
        System.out.println(test);


    }

    public static String reverseString(String e) {
        String temp = "";
        for(int i = e.length(); i > 0; i--){
            char ctemp = e.charAt(i-1);
            temp += Character.toString(ctemp);
        }


        return temp;
    }
}