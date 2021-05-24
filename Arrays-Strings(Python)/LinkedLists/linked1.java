import java.util.LinkedList;
class MyClass { 
  public static void main(String[] args) {
        LinkedList<String> cars = new LinkedList<String>();
        cars.add("Volvo");
        cars.add("BMW");
        cars.add("Ford");
        cars.add("Mazda");
        cars.addFirst("Suzuki");
        cars.addLast("Toyota");
        System.out.println(cars);
        cars.removeFirst();
        cars.removeLast();
        System.out.println(cars);
        // Use getLast() to display the last item in the list
        System.out.println(cars.getLast());
  }
}