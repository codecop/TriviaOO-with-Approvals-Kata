package com.adaptionsoft.games.uglytrivia;

public class Array6<T> {

    private Object[] array = new Object[6];

    public Array6(T init) {
        for (int i = 0; i < 6; i++) {
            set(i, init);
        }
    }

    public void set(int i, T value) {
        array[i] = value;
    }

    @SuppressWarnings("unchecked")
    public T get(int i) {
        return (T) array[i];
    }

}
